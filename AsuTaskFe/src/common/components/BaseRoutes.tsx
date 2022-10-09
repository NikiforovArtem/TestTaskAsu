import React, {memo, useEffect} from 'react';
import {Navigate, Route, Routes, useNavigate} from 'react-router-dom';
import Login from 'components/Login';
import AuthService from 'services/AuthService';
import Dashboard from 'components/Dashboard';
import NotFound from 'common/components/NotFound';


const BaseRoutes = () => {
  const navigate = useNavigate();
  useEffect(() => AuthService.init(() => navigate('/login')), [navigate]);

  return (
    <Routes>
      <Route element={requireAuth(Dashboard)} path="/"/>
      <Route element={requireRedirect(Login)} path="/login" />
      <Route path="*" element={<NotFound />} />
    </Routes>
  )
}

export default memo(BaseRoutes);

const requireAuth = (Children: React.ComponentType) => {
  const isAuthorized = AuthService.isAuthorized();
  return !isAuthorized ? <Navigate replace={true} to="/login" /> : <Children />;
};

const requireRedirect = (Children: React.ComponentType) => {
  const isAuthorized = AuthService.isAuthorized();
  return isAuthorized ? <Navigate replace={true} to="/"/> : <Children />;
};