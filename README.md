# dotnet-wg-manager

## give runtime user access to run systemctl commands without password

/etc/sudoers.d/custom
alex ALL = (root) NOPASSWD: /usr/bin/systemctl restart wg-quick@home

## run site as systemd service

https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/linux-nginx?view=aspnetcore-6.0

