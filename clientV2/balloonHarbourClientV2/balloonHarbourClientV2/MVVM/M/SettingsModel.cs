using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balloonHarbourClientV2.MVVM.M {
    class SettingsModel {
        private AccountModel _Account;

        public SettingsModel(AccountModel account) {
            this.Account = account;
        }

        private AccountModel Account { get => _Account; set => _Account = value; }

    }
}
