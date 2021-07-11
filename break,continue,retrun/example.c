//continue文、break文,return文の違い

#include <stdio.h>

void ex_continue();
void ex_break();
void ex_return();

int main(){
    printf("continue文の場合\n");
    ex_continue();
    printf("break文の場合\n");
    ex_break();
    printf("retrun文の場合\n");
    ex_return();

    return 0;
}

void ex_continue(){
    int count = 0;

    for (int i = 0; i < 10; i++)
    {
        if(i == 5) continue;
        printf("%d\n",i);
        count++;
    }

    printf("result = %d\n",count);
}

void ex_break(){
    int count = 0;

    for (int i = 0; i < 10; i++)
    {
        if(i == 5) break;
        printf("%d\n",i);
        count++;
    }

    printf("result = %d\n",count);
}

void ex_return(){
   
    int count = 0;

    for (int i = 0; i < 10; i++)
    {
        if(i == 5) return;
        printf("%d\n",i);
        count++;
    }

    printf("result = %d\n",count);
    
}