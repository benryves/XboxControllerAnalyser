# Xbox Controller Analyser

This is a simple tool that displays information about connected original Xbox controllers.
It's designed to be similar to [USBView](https://learn.microsoft.com/en-us/windows-hardware/drivers/debugger/usbview)
but uses Xbox-specific requests to extract information about the capabilities of the connected controller.

The connected controller must have a libusb or WinUSB driver installed for it for it to show up in the application.
[Zadig](https://zadig.akeo.ie/) is recommended to install an appropriate driver for the controller.

Devices that act like conventional Xbox game controllers (e.g. game pads, steering wheels, arcade sticks, light guns) can be queried in a "live preview".
This shows the current state of the available buttons and axes.

The [Xbox Input Devices section of the xboxdevwiki](https://xboxdevwiki.net/Xbox_Input_Devices) provides more useful information about Xbox controllers.
