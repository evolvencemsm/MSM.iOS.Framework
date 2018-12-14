using System;
using UIKit;

namespace MSM.iOS.Framework.Alerts
{

    public class Alert 
    {

        #region Private Members

        private static UIAlertAction okAction = UIAlertAction.Create("OK", UIAlertActionStyle.Default, null);
        private static UIAlertAction cancelAction = UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, null);
        private static UIAlertAction deleteAction = UIAlertAction.Create("Delete", UIAlertActionStyle.Destructive, null);
        private static UIAlertAction yesAction = UIAlertAction.Create("Yes", UIAlertActionStyle.Default, null);
        private static UIAlertAction noAction = UIAlertAction.Create("No", UIAlertActionStyle.Default, null);

        #endregion

        #region Constructors 

        public Alert()
        {

        }

        static Alert()
        {

        }

        #endregion 

        #region Static Methods 

        public static UIAlertController Show(string _Title, string _Message)
        {
            
            UIAlertController alertController = UIAlertController.Create(_Title, _Message, UIAlertControllerStyle.Alert);

            alertController.AddAction(okAction);
            alertController.AddAction(cancelAction);

            return alertController;

        }

        #endregion 

    }

}
