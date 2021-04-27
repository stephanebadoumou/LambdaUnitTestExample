using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Lambda.Core;
// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaUnitTestExample
{
    public class Function
    {
        public string FunctionHandler(string input, ILambdaContext context)
        {
            return input?.ToUpper();
        }
    }
    public enum Condition
    {
        EXCELLENT,
        GOOD,
        FAIR,
        BAD
    }
    public class Car
    {      
        public Condition Condition;
        public Car(string make, Condition cond)
        {
            Make = make;
            cond = Condition;
        }
        
        private int speed;
        public int Speed 
        {
            get { return speed; }
            set { 
                speed = value;
                if(speed<-50)
                {
                    Speed = -50;
                }
                else if(speed > 200)
                {
                    Speed = 200;
                }
            }
        
        }
        public string Make;   
    }  
    
}
