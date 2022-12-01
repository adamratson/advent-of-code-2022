// DayOnePartTwo.cpp : Day One Part Two of AOC.
//

#include "DayOnePartTwo.h"

using namespace std;

int main()
{
	std::ifstream input("input.txt");

	int numberOfElves = 3;
	int highestCals[3]{0, 0, 0};

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

			std::sort(highestCals, highestCals + numberOfElves);

			for (int i = 0; i < numberOfElves; i++) {
				if (totalCal > highestCals[i]) {
					highestCals[i] = totalCal;
					break;
				}
			}
		}

		int sum = std::accumulate(highestCals, highestCals + numberOfElves, 0);
		std::cout << "Highest cals: " << sum;
	}
	else {
		std::cout << "Failed to open file.";
		return -1;
	}

	return 0;
}
