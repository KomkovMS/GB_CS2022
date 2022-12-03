/*
Задача с собакой и друзьями. Сколько раз собака перебежит от одного
человека к другому (см. picture)
*/

int friendSpeed1 = 1;
int friendSpeed2 = 2;
int dogSpeed = 5;
int distance = 10000;
int friend = 2;
int time = 0;

int countDog = 0;
int distanceFriendStop = 10;

while(distance > distanceFriendStop)
{
    if (friend % 2 == 0)
    {
        time = distance / (friendSpeed1 + dogSpeed);
    }
    if (friend % 2 != 0)
    {
        time = distance / (friendSpeed2 + dogSpeed);
    }

    distance = distance - (friendSpeed1 + friendSpeed2) * time;
    countDog++;
    friend++;
}

Console.WriteLine($"Собака пробежит от одного друга к другому {countDog} раз");