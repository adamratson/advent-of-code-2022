// DayOne.cpp : Day One of AOC.
//

#include "DayOne.h"

using namespace std;

int main()
{
	std::ifstream input("input.txt");

	int previousHighestCal = 0;

	if (input.is_open()) {
		while (input) {
			std::string line;
			std::getline(input, line);

			int totalCal = 0;
			while (line != "") {
				int cal = stoi(line);
				totalCal += cal;

				std::getline(input, line);
			}

			if (totalCal > previousHighestCal) {
				previousHighestCal = totalCal;
			}
		}

		std::cout << "Highest cal: " << previousHighestCal;
	}
	else {
		std::cout << "Failed to open file.";
		return -1;
	}

	return 0;
}
