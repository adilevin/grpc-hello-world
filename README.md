# grpc-hello-world
A basic grpc demonstration, including a Java server, and client implementations in Java, C# and Python.

## Prerequisites

1. Java
    - Java 1.8
    - Maven
2. Python
    - Python 2.7
    - `pip install grpcio-tools`
3. C#
    - Visual Studio 2015

## How to use

1. Building
    - Clone the repository.
    - Run `mvn clean package`
    - Build [src/main/csharp/HelloWorld/HelloWorld.sln](https://github.com/adilevin/grpc-hello-world/blob/master/src/main/csharp/HelloWorld/HelloWorld.sln)

1. Running the RPC server on port 5001

    - Java: Execute [GreetingServer.java](https://github.com/adilevin/grpc-hello-world/blob/master/src/main/java/GreetingServer.java) is a Java RPC server.

1. Running the client

    - Java: Execute [GreetingClient.java](https://github.com/adilevin/grpc-hello-world/blob/master/src/main/java/GreetingClient.java)
    - Python: Execute [GreetingClient.py](https://github.com/adilevin/grpc-hello-world/blob/master/src/main/python/GreetingClient.py)
    - C#: Execute [GreetingClient.cs](https://github.com/adilevin/grpc-hello-world/blob/master/src/main/csharp/HelloWorld/HelloWorld/GreetingClient.cs)

1. Modifying protobuf message and service definitions

    - Edit [HelloWorld.proto](https://github.com/adilevin/grpc-hello-world/blob/master/src/main/proto/HelloWorld.proto)
    - To regenerate C# code, run [src/main/csharp/HelloWorld/protoc.bat](https://github.com/adilevin/grpc-hello-world/blob/master/src/main/csharp/HelloWorld/protoc.bat)
    - To regenerate Python code, run [src/main/python/protoc.bat](https://github.com/adilevin/grpc-hello-world/blob/master/src/main/python/protoc.bat)

## Instructions for starting new grpc projects

#### Python

    pip install grpcio
    pip install grpcio-tools

More instructions [here](https://grpc.io/docs/quickstart/python.html)

#### C#

Install the following Nuget packages

- Google.Protobuf
- Grpc
- Grpc.Core
- Grpc.Tools

#### Java (Maven)

Add the following to your `pom.xml`:

    <dependencies>
        <dependency>
            <groupId>io.grpc</groupId>
            <artifactId>grpc-netty</artifactId>
            <version>1.4.0</version>
        </dependency>
        <dependency>
            <groupId>io.grpc</groupId>
            <artifactId>grpc-protobuf</artifactId>
            <version>1.4.0</version>
        </dependency>
        <dependency>
            <groupId>io.grpc</groupId>
            <artifactId>grpc-stub</artifactId>
            <version>1.4.0</version>
        </dependency>
        <dependency>
            <groupId>junit</groupId>
            <artifactId>junit</artifactId>
            <version>4.12</version>
            <scope>test</scope>
        </dependency>
    </dependencies>

    <build>
        <plugins>
            <plugin>
                <groupId>org.xolstice.maven.plugins</groupId>
                <artifactId>protobuf-maven-plugin</artifactId>
                <version>0.5.0</version>
                <configuration>
                    <protocArtifact>com.google.protobuf:protoc:3.3.0:exe:${os.detected.classifier}</protocArtifact>
                    <pluginId>grpc-java</pluginId>
                    <pluginArtifact>io.grpc:protoc-gen-grpc-java:1.4.0:exe:${os.detected.classifier}</pluginArtifact>
                </configuration>
                <executions>
                    <execution>
                        <goals>
                            <goal>compile</goal>
                            <goal>compile-custom</goal>
                        </goals>
                    </execution>
                </executions>
            </plugin>
        </plugins>
    </build>



