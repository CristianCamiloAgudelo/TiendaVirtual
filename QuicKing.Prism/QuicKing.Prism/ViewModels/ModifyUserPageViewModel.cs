﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuicKing.Prism.ViewModels
{
    public class ModifyUserPageViewModel : ViewModelBase

    {
        public ModifyUserPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Modify user";
        }
    }
}
