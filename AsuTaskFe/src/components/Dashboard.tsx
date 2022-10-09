import BasicLayout from 'common/components/BasicLayout';
import React, {memo, useCallback, useEffect, useState} from 'react';
import {
  MenuItem,
  Pagination,
  Select,
  SelectChangeEvent,
  Stack,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow
} from '@mui/material';
import BookService from 'services/BookService';
import {useCommunication} from 'common/hooks/useCommunication';
import {IRequestParams} from 'common/models/IRequestParams';
import {IBook} from 'services/models/IBook';
import ErrorMessage from 'common/components/ErrorMessage';
import {IListResponse} from 'common/models/IResponse';

const ROWS_PER_PAGE_ITEMS = [5, 10, 15, 20];

const Dashboard = () => {
  const [page, setPage] = useState(1);
  const [rowsPerPage, setRowPerPage] = useState(2);

  const {data, request, communication} = useCommunication<IRequestParams, IListResponse<IBook>>(BookService.getBooks)
  const isLoading = communication.type === 'requesting';
  const errorMessage = communication.error;

  const onChangePage = useCallback((event: React.ChangeEvent<unknown>, value: number) => setPage(value), [setPage]);
  const onChangeRowsPerPage = useCallback((event: SelectChangeEvent<number>) => setRowPerPage(+event.target.value), [setRowPerPage]);

  useEffect(() => request({pageSize: rowsPerPage, pageNumber: page}), [request, rowsPerPage, page]);

  return (
    <BasicLayout isLoading={isLoading}>
      <Stack spacing={4}>
        <TableContainer>
          <Table>
            <TableHead>
              <TableRow>
                <TableCell>
                  <b>ID</b>
                </TableCell>
                <TableCell align="right">
                  <b>Name</b>
                </TableCell>
                <TableCell align="right">
                  <b>Genre</b>
                </TableCell>
                <TableCell align="right">
                  <b>Author</b>
                </TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {data?.data?.map((row) => (
                <TableRow key={row.id}>
                  <TableCell>{row.id}</TableCell>
                  <TableCell align="right">{row.name}</TableCell>
                  <TableCell align="right">{row.genre}</TableCell>
                  <TableCell align="right">{row.authorName}</TableCell>
                </TableRow>
              ))}
            </TableBody>
          </Table>
        </TableContainer>

        {data?.data && (
          <Stack direction="row" alignItems="center">
            <div style={{width: 180}}>Rows per page:</div>
            <Select
              style={{width: 70, height: 40}}
              value={rowsPerPage}
              label=""
              autoWidth={true}
              onChange={onChangeRowsPerPage}
            >
              {ROWS_PER_PAGE_ITEMS.map(item => (
                <MenuItem key={item} value={item}>{item}</MenuItem>
              ))}
            </Select>

            <Pagination
              sx={{ display: 'flex', justifyContent: 'flex-end', width: '100%'}}
              count={data.totalPages}
              page={data.currentPage}
              onChange={onChangePage}
            />
          </Stack>
        )}
        <ErrorMessage message={errorMessage}/>
      </Stack>

    </BasicLayout>
  )
}

export default memo(Dashboard);
