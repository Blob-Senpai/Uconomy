﻿using System;
using System.Collections.Generic;
using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Core;

namespace fr34kyn01535.Uconomy
{
    public class CommandBalance : IRocketCommand
    {
        public string Name
        {
            get { return "balance"; }
        }
        public string Help
        {
            get { return "Shows the current balance"; }
        }


        public AllowedCaller AllowedCaller
        {
            get
            {
                return AllowedCaller.Player;
            }
        }

        public string Syntax
        {
            get { return ""; }
        }

        public List<string> Aliases
        {
            get { return new List<string>(); }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>() { "uconomy.balance" };
            }
        }

        public void Execute(IRocketPlayer caller,params string[] command)
        {
            decimal balance = Uconomy.Instance.Database.GetBalance(caller.Id);
            UnturnedChat.Say(caller, Uconomy.Instance.Translations.Instance.Translate("command_balance_show", balance, Uconomy.Instance.Configuration.Instance.MoneyName));
        }
    }
}
