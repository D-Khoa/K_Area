#include <Windows.h>
#include <windowsx.h>
#include "resource.h"

const char* ClassName = "Win32API";

LRESULT CALLBACK WndProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam);

BOOL CALLBACK AboutBox(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam);

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow)
{
	WNDCLASSEX wc;
	wc.cbSize = sizeof(WNDCLASSEX);		//Khai bao kich thuoc tren bo nho cua window class
	wc.style = 0;						//Kieu cua Class
	wc.lpfnWndProc = WndProc;			//Thu tuc cua window
	wc.cbClsExtra = 0;					//So luong du lieu toi da cua class
	wc.cbWndExtra = 0;					//nhu tren
	wc.hInstance = hInstance;			//Quan ly thong tin cua so
	wc.hIcon = LoadIcon(GetModuleHandle(NULL), MAKEINTRESOURCE(IDI_ICON1));			//Icon cua class
	wc.hCursor = LoadCursor(NULL, IDC_ARROW);			//Con tro cua class
	wc.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1);		//Background cua class
	wc.lpszMenuName = MAKEINTRESOURCE(IDR_MENU1);								//Con tro tro ve du lieu thanh menu
	wc.lpszClassName = ClassName;						//Ten cua class
	wc.hIconSm = LoadIcon(GetModuleHandle(NULL), MAKEINTRESOURCE(IDI_ICON1));		//Icon nho cua class
	if (!RegisterClassEx(&wc))							//Kiem tra viec dang ky cua so class
	{
		MessageBox(NULL, "CANT REGISTER WINDOW", "ERROR", MB_OK);
		return 0;
	}

	HWND hwnd;
	hwnd = CreateWindowEx(
		WS_EX_CLIENTEDGE,			//Kieu mo rong cua window style
		ClassName,					//Ten class
		"Title win32API",			//Tieu de
		WS_OVERLAPPEDWINDOW,		//Mot kieu cua window style
		//WS_CAPTION,				//Kieu sizeable, khong co nut x
		//WS_DISABLED,				//Window khong the thao tac
		CW_USEDEFAULT,				//Toa do khi window bat dau
		CW_USEDEFAULT,
		240,						//Kich thuoc window
		120,
		NULL,						//Cua so cha
		NULL,						//Handle cua chuong trinh
		hInstance,					//Instance cua chuong trinh
		NULL						//Con tro, dung gui thong tin bo sung
	);
	if (hwnd == NULL)
	{
		MessageBox(NULL, "CANT CREATE WINDOW", "ERROR", MB_OK);
		return 0;
	}
	ShowWindow(hwnd, nCmdShow);
	UpdateWindow(hwnd);

	MSG msg;
	while (GetMessage(&msg, NULL, 0, 0) > 0)		//Lay thong tin tu messeage quere
	{
		TranslateMessage(&msg);					//Dich message
		DispatchMessage(&msg);					//Xac dinh cua so thuc thi
	}
	return msg.wParam;							//Thoat vong lap
}

LRESULT CALLBACK WndProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam)
{
	switch (msg)
	{
	case WM_CLOSE:
		DestroyWindow(hwnd);
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case ID_FILE_EXIT:
			PostQuitMessage(0);
			break;
		case ID_VIEW_ZOOM:
			DialogBox(GetModuleHandle(NULL), MAKEINTRESOURCE(IDD_DIALOG1), hwnd, AboutBox);
			break;
		}
	default:
		return DefWindowProc(hwnd, msg, wParam, lParam);
	}
	return 0;
}

BOOL CALLBACK AboutBox(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam)
{
	switch (msg)
	{
	case WM_INITDIALOG:
		return 1;
	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case IDOK:
			EndDialog(hwnd, IDOK);
			break;
		case IDCANCEL:
			EndDialog(hwnd, IDCANCEL);
			break;
		}
		break;
	default:
		return 0;
	}
	return 1;
}
