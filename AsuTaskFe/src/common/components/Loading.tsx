import React, {memo} from 'react';
import {Box, CircularProgress} from '@mui/material';

const defaultStyles = {
  display: 'flex',
  justifyContent: 'center',
  alignItems: 'center',
  height: '100%'
};

const Loading = () => {
  return (
    <Box sx={defaultStyles}>
      <CircularProgress size={24} />
    </Box>
  );
};

export default memo(Loading);
