using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.WebRequestMethods;

namespace Bot
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }








        //SYSTEM START AND INSTAGRAM URL
        ChromeDriver drv;
        string url = "https://www.instagram.com/accounts/login/";
        //END









        //ACCOUNT LIST
        private List<string[]> accountInfos = new List<string[]>
        {


 new string[] {"alisavci19", "sifre" },
 new string[] {"haydaryilmazz12", "sifre" },
 new string[] {"emreee.dikmennn", "sifre!" },
 new string[] {"serenn.kasim", "sifre!"},
 new string[] {"ozdeacarkan659", "sifre!"},
 new string[] {"atahanadanir01", "sifre!"},
 new string[] {"mehmetadiguzel709", "sifre!"},
 new string[] {"bestamiagiragac06", "sifre!"},
 new string[] {"aykanatagiroglu80", "sifre!"},
 new string[] {"sennuragnar48", "sifre!"},
 new string[] {"tutkumasli", "sifre!"},
 new string[] {"mugenurrahmet", "sifre!"},
 new string[] {"sevincakk01", "sifre!"},
 new string[] {"kayihanakarcali06", "sifre!"},
 new string[] {"lemiakarcay71", "sifre!"},
 new string[] {"cihankarapinar11", "sifre!"},
 new string[] {"rafiakas29", "sifre!"},
 new string[] {"nuhaydarakbilmez66", "sifre!"},
 new string[] {"emineakca41", "sifre!"},
 new string[] {"servetakcagunay26", "sifre!"},
 new string[] {"cilem.akcay11", "sifre!"},
 new string[] {"ali.akdogan15", "sifre!"},
 new string[] {"ayberakfirat", "sifre!"},
 new string[] {"hacerakilli01", "sifre!"},
 new string[] {"ercumentakincilar01", "sifre!"},
 new string[] {"sarperakis15", "sifre!"},
 new string[] {"berkerkiray7", "sifre!"},
 new string[] {"iclalakkoyun48", "sifre!"},
 new string[] {"lemisakkut37", "sifre!"},
 new string[] {"polatcorekci4", "sifre!"},
 new string[] {"keremakman116", "sifre!"},
 new string[] {"haticeakova56", "sifre!"},
 new string[] {"nuketaksan57", "sifre!"},
 new string[] {"senemaksevimm72", "sifre!"},
 new string[] {"aysenaksyoy", "sifre!"},
 new string[] {"pekcan.aksozz", "sifre!"},
 new string[] {"bedirhanaksamoglu2", "sifre!"},
 new string[] {"seminaaktuna765", "sifre!"},
 new string[] {"senaakyildiz29", "sifre!"},
 new string[] {"muyesser.ak11", "sifre!"},
 new string[] {"selinaltin4", "sifre!"},
 new string[] {"baharalbas11", "sifre!"},
 new string[] {"simaaladag", "sifre!"},
 new string[] {"kutlualibeyoglu74", "sifre!"},
 new string[] {"nesibealkan8", "sifre!"},
 new string[] {"bugraalp13", "sifre!"},
 new string[] {"hasanalper.34", "sifre!"},
 new string[] {"mazlumaltan61", "sifre!"},
 new string[] {"eliftugceealtass", "sifre!"},
 new string[] {"ahmetrukennaltayy", "sifre!"},
 new string[] {"yasaraltin19", "sifre!"},
 new string[] {"ranaaltinoklu33", "sifre!"},
 new string[] {"feyzaaltinoz5", "sifre!"},
 new string[] {"burakaltintass7", "sifre!"},
 new string[] {"mervealtiokk", "sifre!"},
 new string[] {"rumeysaaltii2", "sifre!"},
 new string[] {"elifaltinnkaya01", "sifre!"},
 new string[] {"begumaltunn21", "sifre!"}


        };
        //END








        //ACCOUNT LOGIN METHOD
        private void RunInstagramAutomation(string username, string password, string profileUrl, string acc)
        {
            ChromeOptions options = new ChromeOptions();

            // Tarayıcı penceresini tam ekran yapmak için ekle
            options.AddArgument("--start-maximized");
            drv = new ChromeDriver(options);
            drv.Navigate().GoToUrl(url);

            // Sayfanın yüklenmesini bekleyin
            System.Threading.Thread.Sleep(5000); // Dikkat: Daha iyi bir yaklaşım için explicit wait kullanılabilir.

            // Kullanıcı adı ve şifre alanlarını bul ve doldur
            var usernameField = drv.FindElement(By.Name("username"));
            var passwordField = drv.FindElement(By.Name("password"));

            usernameField.SendKeys(username);
            passwordField.SendKeys(password);

            // Giriş yap butonunu bul ve tıkla
            var loginButton = drv.FindElement(By.CssSelector("button[type='submit']"));
            loginButton.Click();

            // Giriş işleminin tamamlanmasını bekleyin
            System.Threading.Thread.Sleep(5000); // Yine, daha iyi bir yöntem explicit wait olacaktır.
            string adres = "https://www.instagram.com/" + acc;
            drv.Navigate().GoToUrl(adres);
            System.Threading.Thread.Sleep(5000);

            var passElements = drv.FindElements(By.CssSelector("._a9_1"));
            if (passElements.Count > 0)
            {
                // Element bulundu, üzerinde işlem yapabilirsiniz.
                var pass = passElements[0]; // Listeden ilk elementi alın.
                pass.Click();
                System.Threading.Thread.Sleep(5000); // Gerekli işlemler için bekleme.
            }
            else
            {
                // Element bulunamadı, hata yönetimi veya alternatif bir işlem yapabilirsiniz.
                Console.WriteLine("Aranan element bulunamadı.");
            }


        }
        //END















        //ACC FOLLOW CLICK
        private void button1_Click(object sender, EventArgs e)
        {

            string account = textBox1.Text;

            for (int i = 0; i < accountInfos.Count; i++)
            {


                string kadi = accountInfos[i][0].ToString();
                string sifre = accountInfos[i][1].ToString();
                RunInstagramAutomation(kadi, sifre, "https://www.instagram.com/", account);
                try
                {
                    var foll = drv.FindElement(By.CssSelector("._ap30"));
                    foll.Click();
                }
                catch (NoSuchElementException)
                {
                    var contra = drv.FindElement(By.CssSelector("._ap31"));
                    contra.Click();
                }


                System.Threading.Thread.Sleep(3000);
                drv.Quit();
            }
            Application.Exit();


        }
        //END









        // LAST POST LIKE CLICK
        private void button2_Click(object sender, EventArgs e)
        {

            string account = textBox1.Text;

            for (int i = 0; i < accountInfos.Count; i++)
            {

                string kadi = accountInfos[i][0].ToString();
                string sifre = accountInfos[i][1].ToString();
                RunInstagramAutomation(kadi, sifre, "https://www.instagram.com/", account);

                var like = drv.FindElement(By.CssSelector("._aagu"));
                like.Click();
                System.Threading.Thread.Sleep(5000);
                var duble = drv.FindElement(By.CssSelector(".xyb1xck"));
                duble.Click();
                drv.Quit();

            }
        }


        //END


        //EXIT BUTTON

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //END



        //TEXT CONTROL
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }
        //END



        //LAST POST COMMENT CLICK
        private void button3_Click(object sender, EventArgs e)
        {


            string account = textBox1.Text;
            string metin = "❤️";
            for (int i = 0; i < accountInfos.Count; i++)
            {

                string kadi = accountInfos[i][0].ToString();
                string sifre = accountInfos[i][1].ToString();
                RunInstagramAutomation(kadi, sifre, "https://www.instagram.com/", account);

                var com = drv.FindElement(By.CssSelector("._aagu"));
                com.Click();

                var prob = drv.FindElement(By.CssSelector(".xaqnwrm"));
                prob.Click();
                System.Threading.Thread.Sleep(3000);

                var ment = drv.FindElement(By.CssSelector(".focus-visible"));

                ment.SendKeys(metin);

                System.Threading.Thread.Sleep(2000);

                var send = drv.FindElement(By.CssSelector(".x1yc6y37"));
                send.Click();

                System.Threading.Thread.Sleep(3000);
                drv.Quit();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form natro = new natro();
            this.Hide();
            natro.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form insta = new insta();
            this.Hide();
            insta.Show();
        }
        //END


    }
}