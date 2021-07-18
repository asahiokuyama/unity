//変数のスコープとは->
//変数の有効範囲のことを示します。
//今回はグローバル変数、ローカル変数、静的ローカル変数を例にあげます。
//言語ごとに他種類あると思いますが、基本はこの３つです。

#include <stdio.h>

void functionA();
void functionB();

//グローバル変数
int a = 10;

int main()
{
    //ローカル変数
    int b = 20;
    int x = a+b;

    for (int i = 0; i < 5; i++)
    {
        functionA();
    }
    for (int i = 0; i < 5; i++)
    {
        functionB();
    }
    
    
    printf("%d\n",a);
    printf("%d\n",b);
    printf("%d\n",x);

    return 0;
}

void functionA(){
    //じゃあこれは？
    int c = 0;
    c = c + 1;
    // printf("%d\n",b);  <-どうなるでしょう？
    printf("staticなし = %d\n",c);
}

void functionB(){
    static int c = 0;
    c = c+1;
    printf("staticあり = %d\n",c);
}

