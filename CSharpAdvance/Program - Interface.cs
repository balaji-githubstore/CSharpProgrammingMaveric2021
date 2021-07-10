//using System;

//namespace CSharpAdvance
//{
//    interface IWebDriver1
//    {
//        void Close(); //public abstract
//        void Quit();
//        String Url { get; set; }
//        void FindElement();
//    }

//    interface IJavascriptExecutor
//    {
//        void ExecuteScript();
//    }
//    interface ITakescre
//    {
//        void screen();
//    }
//    class XBrowser : IWebDriver1,IJavascriptExecutor
//    {
//        public string Url { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//        public void Close()
//        {
//            throw new NotImplementedException();
//        }

//        public void ExecuteScript()
//        {
//            throw new NotImplementedException();
//        }

//        public void FindElement()
//        {
//            throw new NotImplementedException();
//        }

//        public void Quit()
//        {
//            throw new NotImplementedException();
//        }
//    }

//    class FirefoxDriver1 : IWebDriver1, IJavascriptExecutor, ITakescre
//    {
    
//        public void Close()
//        {
//        }

//        public void FindElement()
//        {
            
//        }

//        public void Quit()
//        {
            
//        }

//        public void ExecuteScript()
//        {
           
//        }

//        public void screen()
//        {
//            throw new NotImplementedException();
//        }

//        public string Url
//        {

//            set
//            {
              
//            }
//            get
//            {
//                return Url;
//            }

//        }

//    }

//    class ChromeDriver1 : IWebDriver1, IJavascriptExecutor,ITakescre
//    {

//        public string Url {

//            set
//            {
               
//            }
//            get
//            {
//                return Url;
//            }
        
//        }

      
//        public void Close()
//        {
           
//        }

//        public void FindElement()
//        {
         
//        }

//        public void Quit()
//        {
           
//        }
//        public void ChromeCheck()
//        {

//        }

//        public void ExecuteScript()
//        {
           
//        }

//        public void screen()
//        {
//            throw new NotImplementedException();
//        }
//    }
//    class Program1
//    {
//        static void Main1(string[] args)
//        {

//            //ChromeDriver1 d = new ChromeDriver1();
//            //FirefoxDriver1 d = new FirefoxDriver1();
//            IWebDriver1 d= new FirefoxDriver1();
//            d.Close();
//            d.Close();
//            d.Quit();
//            IJavascriptExecutor js = (IJavascriptExecutor)d;
//            js.ExecuteScript();
//            //d.Url = "";
//            //d.ChromeCheck();

//            ITakescre ts = (ITakescre)d;
//            ts.screen();
//        }
//    }
//}
