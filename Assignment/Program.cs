using Assignment.Q1_Interface;
using Assignment.Q2_Interface;
using Assignment.Q3_Interface;
using System.ComponentModel.DataAnnotations;

namespace Assignment
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1

            // 1 b) To define a blueprint for a class

            // 2 a) private

            // 3 b) No

            // 4 b) Yes, interfaces can inherit from multiple interfaces


            // 5 d) implements

            // 6 a) Yes

            // 7  b) No, all members are implicitly public

            // 8   b) To provide a clear separation between interface and class members

            // 9   b) No, interfaces cannot have constructors

            // 10  c) By separating interface names with commas


            #endregion

            #region Part 2

            #region Q 1
            Circle circle = new Circle();
            circle.Area = 10;
            circle.DispalyShapeInfo();
            Rectangle rectangle = new Rectangle();
            rectangle.Area = 150;
            rectangle.DispalyShapeInfo();
            #endregion

            #region Q 2

            IAuthenticationService authService = new BasicAuthenticationService()
            {
                Username = "Abdo",
                Password = "password",
                Role = Role.User
            };
            
            authService.AuthorizeUser();
            authService.AuthenticateUser();


            #endregion

            #region Q 3

            EmailNotificationService emailNotificationService = new EmailNotificationService();
            SmsNotificationService smsNotificationService = new SmsNotificationService();
            PushNotificationService pushNotificationService = new PushNotificationService();

            emailNotificationService.SendNotification("Hello", "Abdo");
            #endregion

            #endregion


        }
    }
}
