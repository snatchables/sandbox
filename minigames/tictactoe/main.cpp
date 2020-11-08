#include <iostream>

// create a 2d array and init all values to 0
int positions[4][7] = {};
const int rows = 4;
const int columns = 7;

void printPositions()
{
	// outer loop iterates through rows
	for (int i = 0; i < rows; i++)
	{
		// inner loop iterates through elements in current row
		for (int e = 0; e < columns; e++)
		{
			std::cout << positions[i][e];
		}
		std::cout << '\n';
	}
}

void pseudoRefresh()
{
	for (int i = 0; i < 6; i++)
	{
		std::cout << i << '\n';
	}
}

int main()
{
	while (true)
	{
		printPositions();

		int row;
		int column;

		std::cout << "enter a row: ";
		std::cin >> row;
		std::cout << "enter a column: ";
		std::cin >> column;
		row -= 1;
		column -= 1;

		positions[row][column] = 1;

		printPositions();
		break;
	}

	return 0;
}