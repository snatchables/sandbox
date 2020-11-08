#include <iostream>
#include <utility>
#include <array>

int main()
{
    int numbers[] = {10, 30, 4, 1};
    const int length = static_cast<int>(sizeof(numbers)/sizeof(numbers[0]));

    for(int i = 0; i < length; i++)
    {
        if(i == 0)
        {
            std::cout << "input before sort: ";
        }
        std::cout << numbers[i] << ' ';
        if(i == length - 1) {std::cout << '\n' << '\n';}
    }

    // outer loop to repeat passes (stops iterating once once all elements are sorted)
    for(int i = 0; i < length; i++)
    {
        bool swapped = false;
        // inner loop to compare values (1 pass = 1 outer iteration)
        for(int e = 0; e < length; e++)
        {   
            if(numbers[e + 1] > numbers[e])
            {
                std::swap(numbers[e], numbers[e + 1]);
                swapped = true;
            }
        }
        if(!swapped)
        {
            std::cout << "fully sorted on iteration " << i << std::endl;
            break;
        }
    }

    for(int i = 0; i < length; i++)
    {
        if(i == 0)
        {
            std::cout << "input after sort: ";
        }
        std::cout << numbers[i] << ' ';
        if(i == length - 1){std::cout << '\n' << '\n';}
    }
}
