import React, {memo, useCallback, useEffect, useMemo} from 'react';
import {useNavigate} from 'react-router-dom';
import AuthService from 'services/AuthService';
import BasicLayout from 'common/components/BasicLayout';
import {Button, Stack, TextField} from '@mui/material';
import {useCommunication} from 'common/hooks/useCommunication';
import ErrorMessage from 'common/components/ErrorMessage';
import Loading from 'common/components/Loading';

const Login = () => {
  const navigate = useNavigate();

  const navigateToMainPage = useCallback(() => navigate('/', { replace: true }), [navigate]);

  const {request, communication} = useCommunication(AuthService.login);
  const isLoading = communication.type === 'requesting';
  const errorMessage = communication.error;

  const [name, setName] = React.useState<string>('');
  const isDisabledName = useMemo(() => name.length < 1, [name]);
  const onChangeName = useCallback((event: React.ChangeEvent<HTMLInputElement>) => setName(event.target.value), [setName]);

  const [pass, setPass] = React.useState<string>('');
  const isDisabledPass = useMemo(() => pass.length < 1, [pass]);
  const onChangePass = useCallback((event: React.ChangeEvent<HTMLInputElement>) => setPass(event.target.value), [setPass]);

  const isDisabled = useMemo(() => isDisabledName || isDisabledPass, [isDisabledName, isDisabledPass]);
  const onLogin = useCallback(() => request({login: name, password: pass}), [request, name, pass]);

  useEffect(() => {
    if(communication.type === 'success') {
      navigateToMainPage()
    }
  }, [communication.type, navigateToMainPage]);

  return (
    <BasicLayout>
      <Stack spacing={3}>
        <TextField value={name} onChange={onChangeName} label="User name" variant="standard" />
        <TextField value={pass} onChange={onChangePass} label="Password" type="password" variant="standard" />
        <Button disabled={isDisabled} onClick={onLogin} variant="contained">LOGIN</Button>
        {isLoading && <Loading />}
        {errorMessage && <ErrorMessage message={errorMessage} />}
      </Stack>
    </BasicLayout>
  )
}

export default memo(Login);