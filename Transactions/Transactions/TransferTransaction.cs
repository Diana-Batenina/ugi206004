﻿using System;
using Bank;

namespace Transactions
{
    public class TransferTransaction : Transaction
    {
        InterfaceUI ui;
        Account source;
        Account target;

        public TransferTransaction(InterfaceUI ui, Account source, Account target)
        {
            this.ui = ui;
            this.source = source;
            this.target = target;
        }
        public override void Execute()
        {
            var amount = ui.RequestTransferAmount();

            if (amount > source.Funds)
                ui.InformInsufficientFunds();
            else
            {
                source.Funds -= amount;
                target.Funds += amount;
            }          
        }
    }
}