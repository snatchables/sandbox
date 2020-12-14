#include <iostream>


// test class just so i have something to construct
class Vector3
{
public:
    Vector3(int xv, int yv, int zv)
    {
        x = xv;
        y = yv;
        z = zv;
    }

    int x;
    int y;
    int z;
};


int main()
{ 
    // object that is allocated on the stack. 
    Vector3 vector3(5, 7, 8); 

    // object that is allocated on the heap.
    Vector3 *anotherVector3 = new Vector3(99, 12, 14);

    // when accessing the stack allocated object, we just need to use the name of it and the . operator.
    std::cout << "x value of stack vector: " << vector3.x << std::endl;
    std::cout << "memory address of stack vector: " << &vector3 << std::endl << '\n';

    // when accessing the heap allocated object, we need to use brackets to make sure that the indirection occurs first.
    // after dereferencing the pointer, we can access the values where the pointer is pointing to.
    std::cout << "x value of heap vector: " << (*anotherVector3).x << std::endl;
    std::cout << "memory address of heap vector: " << anotherVector3 << std::endl;

    // freeing the heap memory and setting the pointer to null to avoid a dangling pointer. the heap allocated object will be 
    // "deleted" (by deleted we just mean that we are saying to the operating system that we aren't using the memory anymore)
    // where the delete keyword is used. however, stack allocated objects will be automatically "deleted" when the flow of 
    // control leaves the scope of the main function.
    
    delete anotherVector3;
    anotherVector3 = nullptr;

    // the main differences between allocating variables to the stack, and allocating variables to the heap are:
    // 

    return 0;
}