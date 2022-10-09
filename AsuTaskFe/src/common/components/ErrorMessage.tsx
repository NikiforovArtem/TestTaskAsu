import React, {memo} from 'react';
import {Box} from '@mui/material';

interface IProps {
  message?: string;
}

const ErrorMessage = ({message}: IProps) => (
  <Box display="flex" alignSelf="center" color="red">{message}</Box>
)

export default memo(ErrorMessage);