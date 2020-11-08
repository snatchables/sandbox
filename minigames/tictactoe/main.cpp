#include <iostream>

int main()
{
	// create a 2d array and init all values to 0
	int positions[3][3] = {};
	const int rows = 3;
	const int columns = 3;
	
	// outer loop iterates through each row
	for (int i = 0; i < rows; i++)
	{
		// inner loop iterates through each element in the row
		for (int e = 0; e < columns; e++)
		{
			std::cout << positions[i][e];
		}
		std::cout << '\n';
	}

	return 0;
}