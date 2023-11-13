# NAccessControl

## NAccessControl 是什么

NAccessControl 是一个使用简单的访问控制组件。目标是一个简单、容易引入、快速使用的组件，基于RBAC模型符合大多数人的使用习惯。

NAccessControl 工作在 ASP.NET Core 和 EF Core 下，但不只是这样。我们的设计使你可以利用其他组件，如Dapper。


## 入手

```c#
public class FileController
{
    protected IAccessControl ac;

    public void Download()
    {
        var resource = "File";
        var permission = "Download"
        if (!this.ac.roleHasPermission(userId, resource, permission)) {
            throw new Exception("Access denied");
        }
    }
} 
```