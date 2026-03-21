from random import sample


def main():
    print("-" * 30)
    print("LOTTERY NUMBER GENERATOR".center(30))
    print("-" * 30)

    num_games = int(input("How many games should I generate? "))
    print("-=" * 3 + f" GENERATING {num_games} GAMES " + "-=" * 3)

    for i in range(num_games):
        numbers = sample(range(1, 61), 6)
        numbers.sort()
        print(f"Game {i + 1}: {numbers}")

    print("-=" * 5 + " < GOOD LUCK! > " + "-=" * 5)


if __name__ == "__main__":
    main()