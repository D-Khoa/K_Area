// GameRoom.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Library\graphics.h"

DWORD wdWidth = GetSystemMetrics(SM_CXSCREEN);
DWORD wdHeight = GetSystemMetrics(SM_CYSCREEN);

struct SnakeFood
{
	int X;
	int Y;
};

struct SnakePoint
{
	int X0;
	int Y0;
	int X;
	int Y;
};

enum SnakeDirection
{
	UP,
	DOWN,
	LEFT,
	RIGHT
};

void CreateSnake()
{
	int r = 5;
	int gd = 0, gm = 0, maloi;  // gd : graphdriver,  gm: graphmode,

	initgraph(&gd, &gm, "C:/TC/BGI");    // khoi dong do hoa
	circle((wdWidth - r) / 2, (wdHeight - r) / 2, r);
}

int main()
{
	CreateSnake();
	return 0;
}

