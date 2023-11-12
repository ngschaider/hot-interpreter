using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class BaseNode
{

    public abstract void ToCustomStringBuilder(CustomStringBuilder csb);

    public override string ToString() {
        CustomStringBuilder csb = new CustomStringBuilder();
        ToCustomStringBuilder(csb);
        return csb.ToString();
    }

}
