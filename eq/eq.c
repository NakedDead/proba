#include <stdio.h>
#include <math.h>

main(){
	float a,b,c,d,x,x1,x2;

	printf("Equation ax^2+bx+c=0\n");

	printf("Input a=");
	scanf("%f",&a);
	printf("Input b=");
	scanf("%f",&b);
	printf("Input c=");
	scanf("%f",&c);

	printf("\n");

	d = b*b-4*a*c;

	printf("%.0f\n", d);

	if (d < 0)
	{
		printf("No solution");
	}
	else{
		if (d==0)
		{
			x = (-b/2*a);
			printf("x=%.0f", x);
		}
		else
		{
			x1 = (-b + sqrt(d)) / (2*a);
			x2 = (-b - sqrt(d)) / (2*a);
			printf("x1=%.1f;x2=%.1f", x1,x2);
		}
		}
}