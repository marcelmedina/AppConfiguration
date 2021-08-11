# azure-spring-cloud-appconfiguration-config

[Source code][source_code] | [Package (Maven)][package] | [README][readme] | [Product documentation][docs] | [Samples][samples]

# azure-spring-cloud-appconfiguration-config-web

[Source code web][source_code_web] | [Package (Maven) web][package_web] | [Product documentation][docs]

## 2.0.0 - July 22, 2021

* Enables loading from multiple App Configuration stores.
* Each store can load configurations by using key/label `selects`. Many `selects` can be used, default is key = `/applicaiton/*` with label = `${spring.profiles.active}` or if null `\0`. See [README][readme] for full configuration.
* Authentication via Connection String, Managed Identity, or any method supported by Azure Identity SDK, see Token Credential Provider in README.
* App Configuration stores can be monitored for changes. This is done by a specified configuration know as a trigger being checked in the App Configuration store on a set interval. Each individual App Configuration store can be enabled/disabled for monitoring and have a different interval in which they are checked. Monitoring can be done through either a Push or Pull model.
  * Pull Monitoring checks the config store for changes strictly based on how long it has been since the last check and activity in the application.
  * Push Monitoring has the App Configuration store notify the Application that configurations have changed through a web-hook.
* Feature Flag loading can be enabled per config store `spring.cloud.azure.appconfiguration.stores[0].feature-flags.enable`
  * A single label can be used to load feature flags, default `\0` i.e. (No Label).
  * A cache expiration can be set for feature flags.
* Configurations can be set using: Key-Value, Key Vault Reference, Placeholder Values i.e. `${my.config}`, [Json](https://docs.microsoft.com/azure/azure-app-configuration/howto-leverage-json-content-type)

<!-- LINKS -->
[docs]: https://docs.microsoft.com/azure/azure-app-configuration/quickstart-java-spring-app
[package]: https://mvnrepository.com/artifact/com.azure.spring/azure-spring-cloud-appconfiguration-config
[samples]: https://github.com/Azure-Samples/azure-spring-boot-samples/tree/main/appconfiguration
[source_code]: https://github.com/Azure/azure-sdk-for-java/tree/master/sdk/appconfiguration/azure-spring-cloud-appconfiguration-config
[token_credentials]: https://github.com/Azure/azure-sdk-for-java/blob/master/sdk/identity/azure-identity/README.md
[readme]: https://github.com/Azure/azure-sdk-for-java/tree/master/sdk/appconfiguration/azure-spring-cloud-starter-appconfiguration-config

[package_web]: https://mvnrepository.com/artifact/com.azure.spring/azure-spring-cloud-appconfiguration-config-web
[source_code_web]: https://github.com/Azure/azure-sdk-for-java/tree/master/sdk/appconfiguration/azure-spring-cloud-appconfiguration-config-web