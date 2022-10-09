import {CommunicationType, ICommunication} from 'common/models/Communication';
import {useCallback, useMemo, useState} from 'react';
import {AxiosError} from 'axios';

export function useCommunication<RequestParams, ResponseType>(
  request: (...params: RequestParams[]) => Promise<ResponseType>
) {
  const [communication, setCommunication] = useState<ICommunication>({type: CommunicationType.NotAsked});
  const [data, setData] = useState<ResponseType | undefined>(undefined);

  const handleRequest = useCallback((...p: RequestParams[]) => {
    setCommunication({type: CommunicationType.Requesting});
    request(...p)
      .then((response) => {
        setData(response);
        setCommunication({type: CommunicationType.Success})
      })
      .catch((error: AxiosError) => {
        setData(undefined);
        setCommunication({type: CommunicationType.Error, error: error.message})
      })},
    [request]
  );

  return useMemo(
    () => ({
      data,
      request: handleRequest,
      communication,
    }),
    [communication, handleRequest, data]
  );
}
