import React, {memo} from 'react';
import {Box, SxProps, Theme} from '@mui/material';
import Loading from 'common/components/Loading';

const disabledStyle: SxProps<Theme> = {
  px: 20,
  opacity: 0.5,
  pointerEvents: 'none',
  userSelect: 'none'
}

interface IProps {
  isLoading?: boolean;
}

const BasicLayout = ({isLoading, children}: React.PropsWithChildren<IProps>) => {
  return (
    <Box
      display="flex"
      justifyContent="center"
      alignItems="center"
      height="100%"
      sx={isLoading ? disabledStyle : null}
    >
      {isLoading && (
        <Box position="absolute">
          <Loading/>
        </Box>
      )}
      {children}
    </Box>
  )
}

export default memo(BasicLayout);