using System.Collections.Generic;

namespace CoreApp.Models
{
    public static class CustomerContext
    {
        public static List<Customer> customers = new()
        {
            new Customer{Id=0,Name="Dries",SurName="Mertens"},
            new Customer{Id=1,Name="Furkan",SurName="Gonul"},


        };
    }
}
