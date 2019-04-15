using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    class AnonymousMethod
    {

        //Anonymous methods provide a technique to pass a code block as a delegate parameter.
        //Anonymous methods are the methods without a name, just the body.
        //It was introduced in C#2.0 but mostly used with Lambda expressions.
        //An Anonymous method is like a lambda expression except that it lacks implicitly typed parameters, 
        //expression syntax and the ability to compile to an expression tree.

        //What is expression tree?
        ////https://www.tutorialsteacher.com/linq/expression-tree
        ////Expression tree as name suggests is nothing but expressions arranged in a tree-like data structure.
        ////Each node in an expression tree is an expression.
        ////Expression tree is an in-memory representation of a lambda expression. 
        ////It holds the actual elements of the query, not the result of the query.

        //You need not specify the return type in an anonymous method; 
        //it is inferred from the return statement inside the method body.
        //To write an anonymous method, 
        //you include delegate key word followed by a parameter declaration and then a method body.
        //
        //delegate int Transformer (int i);

        //We could write and call anonymous method like below:

        //Transformer sqr= delegate (int x) {return x*x; };
        //Console.WriteLine(sqr(3));

        //Rewriting in Lambda expression
        //Transformer sqr= (int x) =&gt;{return x * x ; };


        public delegate int firstDelegate(int i);
        firstDelegate fD = delegate (int x) { return x + x; };
    }
}
