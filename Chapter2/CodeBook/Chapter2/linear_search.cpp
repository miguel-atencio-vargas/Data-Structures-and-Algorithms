#include <iostream>
#include <vector>
using namespace std;

int linear_search(vector<int> array, int value) {
	int steps = 0;

	for (int i = 0; i < array.size(); i++) {
		printf("%d\n", steps++);

		if(array[i] == value) {
			return i;
		} else if(array[i] > value) {
			break;
		}
	}
	return -1;
}

int main(int argc, char const *argv[])
{
	vector<int> numbers = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 80, 89, 97};
	int position = linear_search(numbers, 8);
	printf("position: %d\n", position);
	return 0;
}