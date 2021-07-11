//continue文、break文,return文の違い

#include <stdio.h>

int main(){
    int count = 0;

    for (int i = 0; i < 10; i++)
    {
        printf("%d\n",count);
        count++;
    }

    printf("result = %d\n",count);
    return 0;
    
}

//continue
// int main(){
//     int count = 0;

//     for (int i = 0; i < 10; i++)
//     {
//         if(i == 5) continue;
//         printf("%d\n",i);
//         count++;
//     }

//     printf("result = %d\n",count);
//     return 0;
    
// }

//break
// int main(){
//     int count = 0;

//     for (int i = 0; i < 10; i++)
//     {
//         if(i == 5) break;
//         printf("%d\n",i);
//         count++;
//     }

//     printf("result = %d\n",count);
//     return 0;
    
// }

//return
// int main(){
//     int count = 0;

//     for (int i = 0; i < 10; i++)
//     {
//         if(i == 5) return 0;
//         printf("%d\n",i);
//         count++;
//     }

//     printf("result = %d\n",count);
    
    
// }