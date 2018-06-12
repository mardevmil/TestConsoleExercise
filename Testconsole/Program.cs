using System;
using Exercise.AdapterPattern;
using Exercise.ChainOfResponsibility;
using Exercise.FactoryPattern;
using Exercise.Observer;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n************************ Singleton Pattern *************************** ");
            // example of using singleton
            Singleton.Instance.TestMethod();
            
            Console.WriteLine("\n************************ Factory Pattern *************************** ");

            var factory = new BasicFactory();
            var block = factory.CreateBlock();
            Console.WriteLine("\nCreated with BasicFactory type: " + block.GetName());

            var factory2 = new SegmentedFactory();
            var block2 = factory2.CreateBlock();
            Console.WriteLine("\nCreated with SegmentedFactory type: " + block2.GetName());

            var generalFactory = new Factory();
            var block3 = generalFactory.CreateBlock(Factory.Type.Basic);
            var block4 = generalFactory.CreateBlock(Factory.Type.Segmented);
            Console.WriteLine("\nCreated with Factory block3: " + block3.GetName() + " block4: " + block4.GetName() );

            Console.WriteLine("\n************************ Adapter Pattern *************************** ");

            IAdapter adapter1 = new AdapterUI1(new UISystem1());
            IAdapter adapter2 = new AdapterUI2(new UISystem2());

            adapter1.IncreaseProgress();
            adapter1.IncreaseHealth();
            adapter2.IncreaseProgress();
            adapter2.IncreaseHealth();
            Console.WriteLine("For additional test press arrow up!");

            Console.WriteLine("\n************************ Facade Pattern *************************** ");

            //Facade
            Mortgage mortgage = new Mortgage();

            //Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Marko Milovanovic");
            bool eligible = mortgage.IsEligible(customer, 60000);
            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));

            Console.WriteLine("\n************************ Chain Of Responsibility Pattern *************************** ");
            var coinsShopHandler = new BuyCoinsHandler();
            var costumeShopHandler = new BuyCostumeHandler();
            var packShopHandler = new BuyPackHandler();

            coinsShopHandler.SetSuccessor(costumeShopHandler);
            costumeShopHandler.SetSuccessor(packShopHandler);

            coinsShopHandler.HandleRequest(ShopItemType.Costume);

            Console.WriteLine("\n************************ Observer Pattern *************************** ");
            Game.Instance.Score++;
            Console.WriteLine("For additional testing press 'I' . We have UIController and AchievementController as observers!");

            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey(true);
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    Console.WriteLine("\nAdapter Pattern testing:");
                    adapter1.IncreaseProgress();
                    adapter1.IncreaseHealth();
                    adapter2.IncreaseProgress();
                    adapter2.IncreaseHealth();                                        
                }

                if (keyinfo.Key == ConsoleKey.I)
                {
                    Console.WriteLine("\nObserver Pattern testing:");
                    Game.Instance.Score++;
                }
            }
            while (keyinfo.Key != ConsoleKey.Spacebar);            
        }
    }
}
