#include <iostream>
#include <vector>
#include<math.h>
using namespace std;

int binary_search(vector<int> array, int value){
	int lower_bound = 0;
	int upper_bound = array.size() - 1;


	int midpoint, value_at_midpoint, steps = 0;

	while(lower_bound<=upper_bound){
		printf("%d\n", steps++);

		midpoint = (lower_bound + upper_bound)/2;
		value_at_midpoint = array[midpoint];

		if(value < value_at_midpoint) {
			 upper_bound = midpoint - 1;
		} else if(value > value_at_midpoint) {
			 lower_bound = midpoint +1;
		} else if( value == value_at_midpoint) {
			 return midpoint;
		}
	}
	return -1;
}
int main(){
	vector<int> numbers = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 80, 89, 97};
	//int ele = sizeof(primes)/4;

	int position = binary_search(numbers, 8);
	printf("position: %d\n", position);
}
