-- Some complex expressions require quite a few temporaries.

-- This is an easier version of many-temps.cl.


class Main inherits IO
{
  a : Int <- 2;
  b : Int <- 1;
  c : Int <- 3;

  main() : Object
  {
    {
      out_int(a+b*(a+b*(a+b*(a+b*(a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b * (a + b))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))));
      out_string( "\n" );
    }
  };
};
