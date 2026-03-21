/*

Description:
Simple stack implementation using static array.
Includes push, pop, peek and display operations.

*/

#include <iostream>

class Stack {
private:
    static const int MAX = 100;
    int top;
    int arr[MAX];

public:
    Stack() {
        top = -1;
    }

    void push(int value) {
        if (isFull()) {
            std::cout << "Stack is full! Cannot push value.\n";
        } else {
            arr[++top] = value;
            std::cout << "'" << value << "' pushed successfully!\n";
        }
    }

    void pop() {
        if (isEmpty()) {
            std::cout << "Stack is empty! Cannot pop value.\n";
        } else {
            std::cout << "'" << arr[top--] << "' removed successfully!\n";
        }
    }

    void peek() {
        if (isEmpty()) {
            std::cout << "Stack is empty! Cannot see top.\n";
        } else {
            std::cout << "Top of stack: '" << arr[top] << "'\n";
        }
    }

    void showStack() {
        if (isEmpty()) {
            std::cout << "Stack is empty! Nothing to show.\n";
        } else {
            for (int i = 0; i <= top; i++) {
                std::cout << arr[i] << " ";
            }
            std::cout << std::endl;
        }
    }

    bool isFull() {
        return top == MAX - 1;
    }

    bool isEmpty() {
        return top == -1;
    }
};

int main() {
    Stack stack;
    int input;
    int opt;

    while (true) {
        std::cout << "\n--- STACK MENU ---\n";
        std::cout << "1. Push\n";
        std::cout << "2. Pop\n";
        std::cout << "3. Peek\n";
        std::cout << "4. Show stack\n";
        std::cout << "0. Exit\n\n";

        std::cout << "Option: ";
        std::cin >> opt;

        switch (opt) {
        case 1:
            std::cout << "Enter a number: ";
            std::cin >> input;
            stack.push(input);
            break;

        case 2:
            stack.pop();
            break;

        case 3:
            stack.peek();
            break;

        case 4:
            stack.showStack();
            break;

        case 0:
            std::cout << "Exiting...\n";
            return 0;

        default:
            std::cout << "Invalid option!\n";
            break;
        }
    }

    return 0;
}