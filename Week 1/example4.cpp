 #include <iostream>
 using namespace std;

 int main()
{
 
    int x = 25, y = 50, z = 75; 
    int *ptr = nullptr;     


    cout << "The values of x, y, and z:\n";
    cout << x << " " << y << " " << z << endl;


    ptr = &x;     
    *ptr = *ptr + 100;   

    ptr = &y;    
    *ptr = *ptr + 100;   

    ptr = &z;     
    *ptr = *ptr + 100;  


    cout << "Again, The values of x, y, and z:\n";
    cout << x << " " << y << " " << z << endl;
    return 0;

}
  