import axiosWrapper from 'common/services/AxiosWrapper';
import {IRequestParams} from 'common/models/IRequestParams';
import {IBook} from 'services/models/IBook';
import {IListResponse} from 'common/models/IResponse';

export const getBooks = async (params: IRequestParams): Promise<IListResponse<IBook>> => {
  const result = await axiosWrapper.get('/book', {params});
  return result.data;
}

const endpoints = {
  getBooks
}

export default endpoints;
