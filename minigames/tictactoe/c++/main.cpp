#include <iostream>

int main()
{
    // boardposition value of 0 = not occupied, 1 = x, 2 = o

    int boardPositions[3][3] = {}; 
    const int rows = 3;
    const int colums = 3;
    
    for(int rowIndex = 0; rowIndex < rows; ++rowIndex)
    {
        for(int columIndex = 0; columIndex < colums; ++columIndex)
        {
            std::cout << boardPositions[rowIndex][columIndex];
            if(columIndex == 2)
            {
                std::cout << '\n';
            }
        }
    }
      
    return 0;
}