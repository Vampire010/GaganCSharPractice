using System;
namespace app
{
    class Customer
    {
            static void test1(string[] args)
            {
                    string customerId = "C101";
                    string _customerName = "Gagan";
                    string @Address = "#12,Richmond Town,Bangalore-560025";

                    long contactNumber = 9876543210;
                    int billID = 4310;
                    double totalprice = 199.80;
                    //bool BillPayed = true;
                    char rating = 'A';
                    int deliverCharge = 10;

                    //addition oprtr
                    double GuestCustBill = totalprice + deliverCharge;

                    //mul , sub and /
                    double RegcustBill = totalprice - (totalprice*10/100);



                Console.WriteLine("********************Customer Details**************");
                Console.WriteLine("Customer Id : " + customerId );
                Console.WriteLine("Customer Name : " + _customerName );
                Console.WriteLine("Address  : " + @Address );
                Console.WriteLine("Contact Number  : " + contactNumber );
                Console.WriteLine("Bill-ID  : " + billID );
                Console.WriteLine("Total Bill  : " + totalprice );
                Console.WriteLine("Bill payed with discount  : " + RegcustBill );
                //Console.WriteLine("Delvery Charge added in Bill payed   : " + deliverCharge );

                Console.WriteLine("Review rating  : " + rating );

                Console.WriteLine("********************Customer Details**************");
                

            }

    }
}