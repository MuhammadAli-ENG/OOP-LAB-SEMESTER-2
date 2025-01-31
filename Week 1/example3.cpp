 #include <iostream>
 using namespace std;
 int main()
 {
           int x = 50;
         int *ptr = nullptr; 
          ptr = &x; 

          cout << "Here is the value in x, printed twice: "<<endl;
          cout << x << endl; 
          cout << *ptr << endl;

         *ptr = 200;

      cout << "Once again, here is the value in x: "<<endl;
      cout << x << endl;   
      cout << *ptr << endl;
      return 0;
  }