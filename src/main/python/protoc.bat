@echo off
rem Requires to pre-install
rem pip install grpcio-tools

@echo on
python -m grpc_tools.protoc -I../proto --python_out=. --grpc_python_out=. ../proto/HelloWorld.proto