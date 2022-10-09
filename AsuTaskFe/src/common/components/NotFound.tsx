import React, {memo} from 'react';
import BasicLayout from './BasicLayout';

const NotFound = () => {
  return (
    <BasicLayout>Page not found</BasicLayout>
  )
}

export default memo(NotFound);