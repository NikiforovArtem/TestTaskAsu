import axios, {AxiosRequestConfig} from 'axios';

const axiosRequestConfig: AxiosRequestConfig = {
  baseURL: process.env.REACT_APP_API_URL,
  headers: {
    'cache-control': 'no-cache',
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*',
    Authorization: `Bearer ${localStorage.getItem('access_token')}`
  },
};

const AxiosWrapper = axios.create(axiosRequestConfig);
export default AxiosWrapper;