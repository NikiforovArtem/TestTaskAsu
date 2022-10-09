import axiosWrapper from 'common/services/AxiosWrapper';
import {IAuth} from 'common/models/IAuth';

class AuthService {
  private static onLogout?: () => void;

  public static init(logout: () => void) {
    AuthService.onLogout = logout;
  }

  public static logout() {
    localStorage.removeItem('access_token');
    AuthService.onLogout && AuthService.onLogout();
  }

  public static async login(data: IAuth): Promise<void> {
    const response = await axiosWrapper.post('/authenticate/login', data);

    if(response.status !== 200) {
      throw Error(response.statusText);
    }

    localStorage.setItem('access_token', response?.data);
    axiosWrapper.defaults.headers.Authorization = `Bearer ${response.data}`;
  }

  public static isAuthorized() {
    return !!localStorage.getItem('access_token');
  }
}

export default AuthService;
