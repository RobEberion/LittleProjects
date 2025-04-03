import pygame
import random
pygame.init()  # initializiert pygames

def draw_square(column, row, color):
    screen_x = column * SQUARE_SIZE
    screen_y = row * SQUARE_SIZE
    pygame.draw.rect(screen, color, (screen_x, screen_y, SQUARE_SIZE, SQUARE_SIZE))  # Rechteck zeichnen

WIN_SIZE = 800
SQUARE_COUNT = 20
SQUARE_SIZE = WIN_SIZE // SQUARE_COUNT
STARTLENGTH = 2
DELAY = 100

# Bildschirmgröße #1
screen = pygame.display.set_mode((WIN_SIZE, WIN_SIZE))
pygame.display.set_caption("Snake")

# Startposition des Kopfes
head_column = SQUARE_COUNT // 2
head_row = SQUARE_COUNT // 2
snake_length = STARTLENGTH
body_parts = []
step_x = 0
step_y = 0
apple_column = random.randrange(0, SQUARE_COUNT-1)
apple_row = random.randrange(0, SQUARE_COUNT-1)


run = True #1
while run:

    # Millisekunden warten
    pygame.time.delay(DELAY)

    for event in pygame.event.get():  # alle Events abfragen
        if event.type == pygame.QUIT:  # Event ist das Schließen des Fensters
            run = False  # Schleife beenden

    #Benutzereingabe #5
    keys = pygame.key.get_pressed()
    if keys[pygame.K_RIGHT]:
        if step_x != -1:
            step_x = 1
            step_y = 0
    elif keys[pygame.K_LEFT]:
        if step_x != 1:
            step_x = -1
            step_y = 0
    elif keys[pygame.K_UP]:
        if step_y != 1:
            step_x = 0
            step_y = -1
    elif keys[pygame.K_DOWN]:
        if step_y != -1:
            step_x = 0
            step_y = 1

    #Schlangenkörper erweitern
    if step_x != 0 or step_y != 0:
        body_parts.append((head_column, head_row))
        if len(body_parts) >= snake_length:
            body_parts.pop(0)

    # Schlange bewegen
    head_column += step_x
    head_row += step_y

    #Testen, ob der Apfel gegessen wurde
    if head_column == apple_column and head_row == apple_row:
        snake_length += 1
        apple_column = random.randrange(0, SQUARE_COUNT - 1)
        apple_row = random.randrange(0, SQUARE_COUNT - 1)

    #Teste, ob das Spiel verloren ist
    self_hit = (head_column, head_row) in body_parts
    vertical_border_hit = head_column < 0 or head_column >= SQUARE_COUNT
    horizontal_border_hit = head_row < 0 or head_row >= SQUARE_COUNT
    if self_hit or vertical_border_hit or horizontal_border_hit:
        head_column = SQUARE_COUNT // 2
        head_row = SQUARE_COUNT // 2
        snake_length = STARTLENGTH
        body_parts = []
        step_x = 0
        step_y = 0
        apple_column = random.randrange(0, SQUARE_COUNT - 1)
        apple_row = random.randrange(0, SQUARE_COUNT - 1)

    # Hintergrundfarbe
    screen.fill((55, 55, 55)) #2

    # Zeichne Schlangenkopf #3
    draw_square(head_column, head_row, (0, 255, 0))

    # Zeichne Schlangenkörper
    for part in body_parts:
        part_column = part[0]
        part_row = part[1]
        draw_square(part_column, part_row, (0, 150, 0))

    # Zeichne Apfel
    draw_square(apple_column, apple_row, (255, 0, 0))

    # Zeichne Raster #4
    for i in range(SQUARE_COUNT):
        line_pos = i * SQUARE_SIZE
        pygame.draw.line(screen, (60, 60, 60), (line_pos, 0), (line_pos, WIN_SIZE), 2)
        pygame.draw.line(screen, (60, 60, 60), (0, line_pos), (WIN_SIZE, line_pos), 2)

    pygame.display.update()

pygame.display.quit()