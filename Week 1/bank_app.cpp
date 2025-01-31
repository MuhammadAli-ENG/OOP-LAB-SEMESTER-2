#include <iostream>
#include <conio.h>

int print_interface();
int empl_menu();
void sign_in();
void deduct_zakat();
int customer_menu();
int deposite_money();
int withdraw_money();
int loan();

using namespace std;

int t_balance = 210000;
int t_loan = 0;

main()
{

    int u_opt = print_interface();

    if (u_opt == 1)
    {
        sign_in();

        int e_opt = empl_menu();

            deduct_zakat();
    }
    else if (u_opt == 2)
    {
        sign_in();

        int c_opt = customer_menu();

            if (c_opt == 1)
            {
                deposite_money();
            }
            else if (c_opt == 2)
            {
                withdraw_money();
            }
            else if (c_opt == 3)
            {
                loan();
            }  
    }
    else if (u_opt == 3)
    {
    }
}
int print_interface()
{
    system("cls");

    int option = -1;

    cout << "Select user type from below..... ";

    cout << endl
         << endl
         << "1) Bank Employee";
    cout << endl
         << "2) Customer";
    cout << endl
         << "3) Go back";

    cout << endl
         << endl
         << "Enter your option: ";
    cin >> option;

    return option;
}
int empl_menu()
{
    system("cls");

    int option = 0;

    cout << "Select any option from below..... ";

    cout << endl
         << endl
         << "1) Deduct Zakat";
    cout << endl
         << "2) Go back";

    cout << endl
         << endl
         << "Enter your option: ";
    cin >> option;
}
int customer_menu()
{
    system("cls");

    int option = 0;

    cout << "Select any option from below..... ";

    cout << endl
         << endl
         << "1) Deposite money";
    cout << endl
         << "2) Withdraw Money";
    cout << endl
         << "3) Loan";
    cout << endl
         << "4) Go back";

    cout << endl
         << endl
         << "Enter your option: ";
    cin >> option;

    return option;
}

int deposite_money()
{
    system("cls");
    cout << endl
         << endl
         << endl
         << endl
         << "The Total Balance is \'" << t_balance << "\' before deposite money.";

    int d_money = 0;

    cout << endl
         << "Enter the amount to deposite: ";
    cin >> d_money;

    t_balance = t_balance + d_money;
    cout << endl
         << "The Total Balance becomes \'" << t_balance << "\' after deposite money.";

    return 1;
}
int withdraw_money()
{
    system("cls");
    cout << endl
         << endl
         << endl
         << endl
         << "The Total Balance is \'" << t_balance << "\' before withdraw money.";

    int w_money = 0;

    cout << endl
         << "Enter the amount to withdraw: ";
    cin >> w_money;

    t_balance = t_balance - w_money;
    cout << endl
         << "The Total Balance becomes \'" << t_balance << "\' after withdraw money.";

    return 1;
}
int loan()
{
    system("cls");
    cout << endl
         << endl
         << endl
         << endl
         << "The Total Loan is \'" << t_loan << "\' ";

    int l_money = 0;

    cout << endl
         << "Enter the amount you want to get loan: ";
    cin >> l_money;

    t_loan = t_loan + l_money;
    cout << endl
         << "The Total Balance becomes \'" << t_loan << "\' after withdraw money.";

    return 1;
}
void deduct_zakat()
{
    system("cls");

    cout << endl
         << endl
         << endl
         << endl
         << "The Total Balance is \'" << t_balance << "\' before zakat deduction.";
    int zakat = t_balance * (2.5 / 100);

    cout << endl
         << endl
         << endl
         << endl
         << "The balance after zakat deduction is \'" << t_balance - zakat << "\'";

    getche();
}
void sign_in()
{
    string password;
    system("cls");

    cout << endl
         << endl
         << endl
         << endl
         << endl;
    cout << "-----<(Sign In Menu)>-----" << endl
         << endl
         << endl
         << endl
         << endl;

    cout << "Enter your password: ";
    cin >> password;

    system("cls");

    cout << endl
         << endl
         << endl
         << endl
         << endl;

    cout << "------------------(Congratulation You have Sign In Successfully)--------------------";

    getche();
}