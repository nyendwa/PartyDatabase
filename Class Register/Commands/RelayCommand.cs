﻿using System;
using System.Windows.Input;

namespace Class_Register.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<object> _Execute { get; set; }
        private Predicate<object> _CanExcute { get; set; }


        public RelayCommand(Action<object> ExcuteMethod, Predicate<object> CanExcuteMethod)
        {

            _Execute = ExcuteMethod;
            _CanExcute = CanExcuteMethod;

        }



        public bool CanExecute(object? parameter)
        {
            return _CanExcute(parameter);
        }

        public void Execute(object? parameter)
        {
            _Execute(parameter);
        }
    }
}
