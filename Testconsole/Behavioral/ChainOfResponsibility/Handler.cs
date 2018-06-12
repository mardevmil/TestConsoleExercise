using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.ChainOfResponsibility
{
    public enum ShopItemType
    {
        Coins,
        Costume,
        Pack
    }

    abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(ShopItemType type);
    }

    class BuyCoinsHandler : Handler
    {
        public override void HandleRequest(ShopItemType type)
        {
            if (type == ShopItemType.Coins)
            {
                Console.WriteLine("Buy coins logic! Handler: {0}", this.GetType().Name);
            }
            else if (successor != null)
            {
                successor.HandleRequest(type);
            }
        }
    }

    class BuyCostumeHandler : Handler
    {
        public override void HandleRequest(ShopItemType type)
        {
            if (type == ShopItemType.Costume)
            {
                Console.WriteLine("Buy costume logic! Handler: {0}", this.GetType().Name);
            }
            else if (successor != null)
            {
                successor.HandleRequest(type);
            }
        }
    }

    class BuyPackHandler : Handler
    {
        public override void HandleRequest(ShopItemType type)
        {
            if (type == ShopItemType.Pack)
            {
                Console.WriteLine("Buy pack logic! Handler: {0}", this.GetType().Name);
            }
            else if (successor != null)
            {
                successor.HandleRequest(type);
            }
        }
    }
}
