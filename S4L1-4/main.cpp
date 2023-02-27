#include <iostream>
//#include <time.h> 

int main() {
	//clock_t start = clock();

	int S[21] = {0};
	for (int i = 0; i < 21; i++) {
		S[i] = i * i;
	}

	int buf;
	for (int i = 1; i <= 20; i++) {
		for (int j = 1; j < i; j++) {
			buf = S[i] - S[j];
			for (int k = 1; k < i; k++) {
				if (buf == S[k]) {
					std::cout << j << "^2 + " << k << "^2 = " << i << "^2\n";
				}
				else {
					if (buf < S[k])
						break;
				}
			}
		}
	}

	//clock_t end = clock();
	//double seconds = (double)(end - start) / CLOCKS_PER_SEC;
	//std::cout << "The time: " << seconds << " seconds\n";
	// 4-5 миллисекунд

	return 0;
}
