using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp.Model;
using WpfApp.View;

namespace WpfApp.ViewModel
{
    class LoginService : INotifyPropertyChanged
    {
        private Window _mainwindow;
        public LoginService(Window mainwindow)
        {
            _mainwindow = mainwindow;
        }
        //数据绑定通知
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private Login_User _LoginUser = new Login_User();

        public string UserName
        {
            get { return _LoginUser.UserName; }
            set
            {
                _LoginUser.UserName = value;
                OnPropertyChanged("UserName");
            }
        }

        public string PassWord
        {
            get { return _LoginUser.PassWord; }
            set
            {
                _LoginUser.PassWord = value;
                OnPropertyChanged("PassWord");
            }
        }

        public void LoginFuc()
        {
            if (UserName == "admin" && PassWord == "123")
            {
                MessageBox.Show("登录成功！");
                MainInterface mainInterface = new MainInterface();
                mainInterface.Show();
                _mainwindow.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误！");
                PassWord = "";
            }
        }

        public ICommand LoginCommand { get { return new LoginCommand(LoginFuc, () => true); } }
    }

    //事件绑定类
    public class LoginCommand : ICommand
    {
        readonly Func<bool> _canExecute;
        readonly Action _execute;

        public LoginCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object? parameter)
        {
            if (_canExecute != null)
            {
                return _canExecute();
            }
            return true;
        }
        public void Execute(object? parameter)
        {
            _execute();
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
