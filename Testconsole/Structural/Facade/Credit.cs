using System;

namespace Exercise
{
    /// The 'Subsystem ClassA' class
	class Bank
	{
	    public bool HasSufficientSavings(Customer c, int amount)
	    {
	        Console.WriteLine("Check bank for " + c.Name);
	        return true;
	    }
    }

    /// The 'Subsystem ClassB' class
    class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
    	    Console.WriteLine("Check credit for " + c.Name);
    	    return true;
        }
	}
	 
	/// The 'Subsystem ClassC' class
	class Loan
	{
	    public bool HasNoBadLoans(Customer c)
	    {
	        Console.WriteLine("Check loans for " + c.Name);
	        return true;
	    }
	}
	 
	class Customer
    {
	    private string _name;
	 
	    public Customer(string name)
	    {
	      this._name = name;
	    }
	 
	    public string Name
	    {
	      get { return _name; }
	    }
	}

}
