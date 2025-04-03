import random
import os
import time


class Snake:
    def __init__(self, x, y):  # Constructor
        self.body = [(x, y)]
        self.direction = (0, -1)  # Start moving up

    # def move(self):
    #     head = self.body[0] #sets head at first element of body
    #     new_head = ((head[0] + self.direction[0]) % Game.WIDTH,(head[1] + self.direction[1]) % Game.HEIGHT) #Calculates new head position
    #     self.body.insert(0, new_head) #inserts new head at the beginning of the body

    def move(self):
        head = self.body[0]  # Set head as the first element of the body
        new_head = (head[0] + self.direction[0], head[1] + self.direction[1])  # Calculate new head position without wrapping

        self.body.insert(0, new_head)  # Insert new head at the beginning of the body
        return True  # No collision, move is successful

    def grow(self):
        # The snake grows by not removing the tail in the next move
        pass

    def check_collision(self):  # checks if head is outside the board or collides with itself
        head = self.body[0]
        if (head[0] < 0 or head[0] >= Game.WIDTH or head[1] < 0 or head[1] >= Game.HEIGHT):
            return True
        return head in self.body[1:]

    # --------------------------------------------------------------------------------------------------


class Apple:
    def __init__(self):  # places apple at beginning of game
        self.position = self.generate_position()

    def generate_position(self):
        return (random.randint(0, Game.WIDTH - 1), random.randint(0, Game.HEIGHT - 1))


# --------------------------------------------------------------------------------------------------

class Game:
    WIDTH, HEIGHT = 20, 10

    def __init__(self):  # creates game
        self.snake = Snake(self.WIDTH // 2, self.HEIGHT // 2)  # creates snake object with starting position
        self.apple = Apple()  # creates apple object
        self.score = 0
        self.game_over = False

    def draw(self):  # checks os for clearing screen command
        os.system('cls' if os.name == 'nt' else 'clear')

        board = [[' ' for _ in range(self.WIDTH)] for _ in range(self.HEIGHT)]  # creates board

        for sx, sy in self.snake.body:  # writes snake on board
            board[sy][sx] = 'O'

        ax, ay = self.apple.position  # writes apple on board
        board[ay][ax] = '@'

        print('+' + '-' * self.WIDTH + '+')  # definition of board
        for row in board:
            print('|' + ''.join(row) + '|')
        print('+' + '-' * self.WIDTH + '+')
        print(f"Score: {self.score}")

    def update(self):
        self.snake.move()
        if self.snake.body[0] == self.apple.position:
            self.score += 5
            self.snake.grow()
            self.apple = Apple()
        else:
            self.snake.body.pop()

        # if self.snake.check_collision():
        #    self.game_over = True
        #   return

        self.game_over = self.snake.check_collision()

    def run(self):
        while not self.game_over:
            self.draw()
            direction = input("Enter direction (w/a/s/d) or 'q' to quit: ").lower()
            if direction == 'q':
                break
            elif direction == 'w' and self.snake.direction != (0, 1):
                self.snake.direction = (0, -1)
            elif direction == 's' and self.snake.direction != (0, -1):
                self.snake.direction = (0, 1)
            elif direction == 'a' and self.snake.direction != (1, 0):
                self.snake.direction = (-1, 0)
            elif direction == 'd' and self.snake.direction != (-1, 0):
                self.snake.direction = (1, 0)
            self.update()

        print("Game Over!")
        print(f"Final Score: {self.score}")



# Start the game
game = Game()
game.run()

