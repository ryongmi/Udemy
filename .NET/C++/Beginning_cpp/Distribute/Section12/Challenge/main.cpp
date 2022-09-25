// Section 12
// Challenge

/* Write a C++ function named apply_all that expects two arrays of integers and their sizes and
  dynamically allocates a new array of integers whose size is the product of the 2 array sizes
  
  The function should loop through the second array and multiplies each element across each element of array 1 and store the
  product in the newly created array.
  
  The function should return a pointer to the newly allocated array.
  
  You can also write a print function that expects a pointer to an array of integers and its size and display the
  elements in the array.
    
  For example,
  
  Below is the output from the following code which would be in main:
  
    int array1[] {1,2,3,4,5};
    int array2[] {10,20,30};
    
    cout << "Array 1: " ;
    print(array1,5);
    
    cout << "Array 2: " ;
    print(array2,3);
    
    int *results = apply_all(array1, 5, array2, 3);
    cout << "Result: " ;
    print(results,15);
   
   Output
   ---------------------
   Array 1: [ 1 2 3 4 5 ]
   Array 2: [ 10 20 30 ]
   Result: [ 10 20 30 40 50 20 40 60 80 100 30 60 90 120 150 ]
*/
  
#include <iostream>

using namespace std;

void print(const int *const array, const size_t array_size) {
    cout<<"[ ";
    for(size_t num=0; num<array_size; num++)
      cout<<array[num]<<" ";
    cout<<"]"<<endl;
}

int *apply_all(const int *const array1, const size_t array1_size, const int *const array2, const size_t array2_size) {
  // 정수 포인터를 반환해야 하기 때문에 *를 사용

    int *results {};
    results = new int[array1_size * array2_size];
    // 동적 정수 배열, 동적으로 할당하는 이유는 apply_all 함수에서만 사용할 것이 아니라 프로그램이 끝날때까지 사용하기 위해.

    int count{0};

    for(size_t num2=0; num2<array2_size; num2++)
      for(size_t num1=0; num1<array1_size; num1++){
        results[count] = array1[num1] * array2[num2];
        count++;
      }

  return results;
}

int main() {
    const size_t array1_size {5};
    const size_t array2_size {3};
    
    int array1[] {1,2,3,4,5};
    int array2[] {10,20,30};
    
    cout << "Array 1: " ;
    print(array1,array1_size);
    
    cout << "Array 2: " ;
    print(array2,array2_size);
    
    int *results = apply_all(array1, array1_size, array2, array2_size);
    constexpr size_t results_size {array1_size * array2_size};

    cout << "Result: " ;
    print(results, results_size);
    
    cout << endl;

    delete [] results;
    return 0;
}