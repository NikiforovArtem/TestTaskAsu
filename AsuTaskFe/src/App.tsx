import React from 'react';
import {BrowserRouter} from 'react-router-dom';
import BaseRoutes from './common/components/BaseRoutes';

function App() {
  return (
    <BrowserRouter>
      <BaseRoutes />
    </BrowserRouter>
  );
}

export default App;

